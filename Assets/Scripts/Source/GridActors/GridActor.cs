using BattleRoyalRhythm.Surfaces;
using System;
using Tools;
using UnityEngine;

namespace BattleRoyalRhythm.GridActors
{
    [Flags]
    public enum ActorTag
    {
        Nothing = 0,
        Hero = 1,
        Passive = 2,
        Villain = 4,
        Intangible = 8
    }

    [Flags]
    public enum CollisionDirectionMask
    {
        Nothing = 0,
        Left = 1,
        Right = 2,
        Up = 4,
        Down = 8,
        Everything = 15
    }

    public enum Direction : byte
    {
        Left,
        Right
    }

    #region Event Delegates
    /// <summary>
    /// Handles a change in an actor's surface.
    /// </summary>
    /// <param name="newSurface">The new assigned surface.</param>
    public delegate void SurfaceChangedHandler(Surface newSurface);
    /// <summary>
    /// Handles the event in which this actor is removed from the grid.
    /// </summary>
    /// <param name="actor">The actor that was removed.</param>
    public delegate void ActorRemovedHandler(GridActor actor);
    #endregion

    /// <summary>
    /// Scene instance for the base class of grid actors.
    /// </summary>
#if UNITY_EDITOR
    [ExecuteInEditMode]
#endif
    public abstract class GridActor : MonoBehaviour
    {
        #region Common Inspector Fields
        [Header("Beat Action Frequency")]
        [Tooltip("The number of beats between each action that this actor takes.")]
        [SerializeField][Min(1)] protected int beatsPerAction = 1;
        [Tooltip("Offsets the action when created (only matters if beats per action greater than one).")]
        [SerializeField][Min(0)] private int actionOffset = 0;
        [Tooltip("")]
        [SerializeField][ReadonlyField] private int beatsUntilNextAction = 0;
        [Header("Actor Interaction")]
        [Tooltip("The tags associated with this actor.")]
        [SerializeField] private ActorTag tags = default;
        [Tooltip("The tags that this actor blocks in collisions.")]
        [SerializeField] private ActorTag blocksTags = default;
        [Tooltip("The directions that this actor blocks in.")]
        [SerializeField] private CollisionDirectionMask blocksDirections = default;
        [Header("Surface Positioning")]
        [Tooltip("The current surface that this actor is on.")]
        [SerializeField] private Surface currentSurface = null;
        [Tooltip("The direction the actor is facing in.")]
        [SerializeField] private Direction direction = Direction.Right;
        [Tooltip("The tile location of the actor on this surface.")]
        [SerializeField] private Vector2Int tile = Vector2Int.zero;
        [Tooltip("The floating point location of the actor.")]
        [SerializeField][ReadonlyField] private Vector2 exactLocation = Vector2.zero;
        [Tooltip("The vertical height of this actor.")]
        [SerializeField][Min(1)] private int tileHeight = 2;
        #endregion
        #region Common Properties Implementation
        /// <summary>
        /// This actor's tags.
        /// </summary>
        public ActorTag Tags
        {
            get => tags;
            protected set => tags = value;
        }
        /// <summary>
        /// The tags that this actor blocks.
        /// </summary>
        public ActorTag BlocksTags
        {
            get => blocksTags;
            protected set => blocksTags = value;
        }
        /// <summary>
        /// The incoming directions that this actor blocks.
        /// </summary>
        public CollisionDirectionMask BlocksDirections
        {
            get => blocksDirections;
            protected set => blocksDirections = value;
        }
        /// <summary>
        /// The number of tiles tall that this actor is.
        /// Extending upwards from Tile.
        /// </summary>
        public int TileHeight
        {
            get => tileHeight;
            protected set => tileHeight = value;
        }
        /// <summary>
        /// The world that this grid actor is on.
        /// </summary>
        public GridWorld World { get; private set; }
        /// <summary>
        /// The surface that this actor is on. Setting
        /// this will teleport the actor to another surface.
        /// </summary>
        public Surface CurrentSurface
        {
            get => currentSurface;
            set
            {
                if (value != currentSurface)
                {
                    currentSurface = value;
                    RefreshPosition();
                    SurfaceChanged?.Invoke(value);
                }
            }
        }
        /// <summary>
        /// The current tile of the grid actor.
        /// Setting this directly will teleport the actor.
        /// </summary>
        public Vector2Int Tile
        {
            get => tile;
            set
            {
                tile = value;
                exactLocation = value;
                RefreshPosition();
            }
        }
        /// <summary>
        /// The current location of the actor with floating
        /// point precision.
        /// </summary>
        public Vector2 Location
        {
            get => exactLocation;
            set
            {
                exactLocation = value;
                // Update the Tile to be the closest tile.
                tile = new Vector2Int(
                    Mathf.RoundToInt(exactLocation.x),
                    Mathf.RoundToInt(exactLocation.y));
                RefreshPosition();
            }
        }
        /// <summary>
        /// The current direction the actor is facing
        /// in on the grid.
        /// </summary>
        public Direction Direction
        {
            get => direction;
            set
            {
                direction = value;
                OnDirectionChanged(value);
            }
        }
        #endregion
        #region Common Events Implementation
        /// <summary>
        /// Called when this grid actor has been removed from
        /// interactions on the grid.
        /// </summary>
        public virtual event ActorRemovedHandler RemovedFromGrid;
        /// <summary>
        /// Called whenever this actor's surface changes.
        /// </summary>
        public virtual event SurfaceChangedHandler SurfaceChanged;
        #endregion

        #region Scene Editing State
        // Store the locked transform values. If this is not
        // serialized, the programmed position is lost when
        // reopening the scene (TODO fix this in ProgrammedTransform).
        [SerializeField][HideInInspector] private ProgrammedTransform programmedTransform;
        #endregion

        public void RefreshPosition()
        {
            if (currentSurface != null)
            {
                exactLocation = new Vector2(
                    Mathf.Clamp(exactLocation.x, 0.5f, currentSurface.LengthX + 0.5f),
                    Mathf.Clamp(exactLocation.y, 0.5f, currentSurface.LengthY + 0.5f));
                Vector2 newLoc = new Vector2(exactLocation.x - 0.5f, exactLocation.y - 0.5f);
#if UNITY_EDITOR
                if (programmedTransform == null)
                    InitializeLock();
#endif
                programmedTransform.Position = currentSurface.GetLocation(newLoc);
                programmedTransform.Rotation = Quaternion.LookRotation(currentSurface.GetRight(newLoc), currentSurface.GetUp(newLoc));
            }
        }

#if UNITY_EDITOR
        protected virtual void OnEnable() => InitializeLock();
        protected virtual void Reset() => InitializeLock();
        private void InitializeLock()
        {
            programmedTransform = GetComponent<ProgrammedTransform>();
            if (programmedTransform == null)
                programmedTransform = gameObject.AddComponent<ProgrammedTransform>();
            programmedTransform.CurrentVisibility = ProgrammedTransform.Visibility.Hidden;
        }
        protected virtual void OnDestroy()
        {
            if (!Application.isPlaying)
                DestroyImmediate(programmedTransform);
        }

        protected virtual void OnDrawGizmos()
        {

        }

        protected virtual void OnValidate()
        {
            beatsUntilNextAction = Mathf.Max(beatsPerAction - actionOffset, 0);
            exactLocation = Tile;
            if (currentSurface != null)
            {
                Location = new Vector2(
                    Mathf.Clamp(exactLocation.x, 1f, currentSurface.LengthX),
                    Mathf.Clamp(exactLocation.y, 1f, currentSurface.LengthY));
                RefreshPosition();
            }
        }
#else
        protected virtual void OnEnable() { }
        protected virtual void OnValidate() { }
        protected virtual void OnDestroy() { }
#endif

        /// <summary>
        /// Initializes this actor to the grid world.
        /// </summary>
        /// <param name="world">The grid world the actor will exist on.</param>
        public virtual void InitializeGrid(GridWorld world)
        {
            World = world;
            Direction = direction;
            World.BeatService.BeatElapsed += OnBeatElapsed;
        }
        /// <summary>
        /// Returns true if the grid actor intersects
        /// the given tile.
        /// </summary>
        /// <param name="checkTile">The tile to check.</param>
        /// <returns>True if the bounds of this actor intersect the given tile.</returns>
        public virtual bool IsIntersecting(Vector2Int checkTile)
        {
            return
                checkTile.x == tile.x &&
                checkTile.y >= tile.y &&
                checkTile.y <= tile.y + tileHeight - 1;
        }

        /// <summary>
        /// Implement this if the actor should respond a change
        /// in direction.
        /// </summary>
        /// <param name="direction">The updated direction of the actor.</param>
        protected virtual void OnDirectionChanged(Direction direction) { }

        public float GetActionInterpolant()
        {
            return ((beatsPerAction - beatsUntilNextAction) + World.BeatService.CurrentInterpolant) / beatsPerAction;
        }


        public bool IsActionBeat { get; private set; }
        protected virtual void OnBeatElapsed(float beatTime)
        {
            beatsUntilNextAction--;
            if (beatsUntilNextAction <= 0)
            {
                IsActionBeat = true;
                beatsUntilNextAction = beatsPerAction;
            }
            else
                IsActionBeat = false;
        }
    }
}

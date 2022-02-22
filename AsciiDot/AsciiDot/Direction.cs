using System;
using System.Collections.Generic;
using System.Linq;

namespace AsciiDot
{
    /**
     * <summary>
     *     A small function to iterate over value of an enum (not taken from stake overflow):
     *     https://stackoverflow.com/questions/972307/how-to-loop-through-all-enum-values-in-c
     * </summary>
     */
    public static class EnumUtil
    {
        // Yes it is a dark magic (no problem if you don't understand now)
        public static IEnumerable<T> GetValues<T>() =>
            Enum.GetValues(typeof(T)).Cast<T>();
    }

    public enum Direction
    {
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3
    }

    public static class DirUtils
    {
        /**
          * <summary>
          * check if 2 directions are on the same axes.
          * </summary>
          *
          * <example>
          * <code>
          *     Console.WriteLine(DirUtils.SameAxis(Direction.Up, Direction.Down));
          *     Console.WriteLine(DirUtils.SameAxis(Direction.Up, Direction.Left));
          * </code>
          * 
          * the given snippet give
          *
          * <code>
          *     True
          *     False
          * </code>
          * </example>
          *
          * <param name="d1">the first direction</param>
          * <param name="d2">the second direction</param>
          *
          * <returns>
          * True if <paramref name="d1"/> et <paramref name="d2"/> or the same axes. Otherwise False.
          * </returns>
          */
        public static bool SameAxis(Direction d1, Direction d2)
        {
            bool res = false;
            if ((d1 == Direction.Up || d1 == Direction.Down) && (d2 == Direction.Up || d2 == Direction.Down))
            {
                res = true;
            }
            if ((d1 == Direction.Left || d1 == Direction.Right) && (d2 == Direction.Left || d2 == Direction.Right))
            {
                res = true;
            }
            return res;
        }

        /**
          * <summary>
          * Rotate the given direction clockwise.
          * </summary>
          *
          * <example>
          * <code>
          *     Console.WriteLine(DirUtils.Rotate(Direction.Up));
          *     Console.WriteLine(DirUtils.Rotation(Direction.Left));
          * </code>
          * 
          * the given snippet give
          *
          * <code>
          *     Direction.Right
          *     Direction.Up
          * </code>
          * </example>
          *
          * <param name="direction">the direction to rotate</param>
          *
          * <returns>
          * The clockwise rotated direction <paramref name="direction"/>.
          * </returns>
          */
        public static Direction Rotate(Direction direction)
        {
            if (direction == Direction.Left)
            {
                return Direction.Up;
            }
            else
            {
                return direction + 1;
            }
        }

        /**
          * <summary>
          * Give the opposite direction of the given one.
          * </summary>
          *
          * <example>
          * <code>
          *     Console.WriteLine(DirUtils.Invert(Direction.Up));
          *     Console.WriteLine(DirUtils.Invert(Direction.Left));
          * </code>
          * 
          * the given snippet give
          *
          * <code>
          *     Direction.Down
          *     Direction.Right
          * </code>
          * </example>
          *
          * <param name="direction">the direction to invert</param>
          *
          * <returns>
          * The opposite direction of <paramref name="direction"/>.
          * </returns>
          */
        public static Direction Invert(Direction direction)
        {
            Direction res = direction;
            switch (direction)
            {
                case Direction.Up:
                    res = Direction.Down;
                    break;
                case Direction.Down: 
                    res = Direction.Up;
                    break;
                case Direction.Left:
                    res = Direction.Right;
                    break;
                case Direction.Right:
                    res = Direction.Left;
                    break;
            }
            return res;
        }

        /**
          * <summary>
          * Give the X component of the direction.
          * </summary>
          *
          * <example>
          * <code>
          *     Console.WriteLine(DirUtils.DeltaX(Direction.Up));
          *     Console.WriteLine(DirUtils.DeltaX(Direction.Left));
          * </code>
          * 
          * the given snippet give
          *
          * <code>
          *     0
          *     -1
          * </code>
          * </example>
          *
          * <param name="direction">the direction whose component we must find</param>
          *
          * <returns>
          * The component of the direction.
          * </returns>
          */
        public static int DeltaX(Direction direction)
        {
            int res = 0;
            switch (direction)
            {
                case Direction.Left:
                    res = -1;
                    break;
                case Direction.Right:
                    res = 1;
                    break;
                default:
                    break;
            }
            return res;
        }

        /**
          * <summary>
          * Give the Y component of the direction.
          * </summary>
          *
          * <example>
          * <code>
          *     Console.WriteLine(DirUtils.DeltaY(Direction.Up));
          *     Console.WriteLine(DirUtils.DeltaY(Direction.Left));
          * </code>
          * 
          * the given snippet give
          *
          * <code>
          *     1
          *     0
          * </code>
          * </example>
          *
          * <param name="direction">the direction whose component we must find</param>
          *
          * <returns>
          * The component of the direction.
          * </returns>
          */
        public static int DeltaY(Direction direction)
        {
            int res = 0;
            switch (direction)
            {
                case Direction.Down:
                    res = -1;
                    break;
                case Direction.Up:
                    res = 1;
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
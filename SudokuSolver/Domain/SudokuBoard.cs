using System.Collections.Generic;

namespace Domain
{
    public class SudokuBoard
    {
        public List<Cell> AllCells { get; }
        public Grouping[] Rows { get; }
        public Grouping[] Columns { get; }

        public SudokuBoard()
        {
            Columns = new Grouping[9];
            Rows = new Grouping[9];
            AllCells = new List<Cell>();
        }
    }

    public class Grouping
    {
        public Grouping(GroupingOrientation orientation)
        {
            Orientation = orientation;
            Cells = new Cell[9];
        }

        public GroupingOrientation Orientation { get; }

        public Cell[] Cells { get; } 
    }

    public class Cell
    {
        public int VerticalPostion { get; set; }

        public int HorizontalPosition { get; set; }

        public int PositionInBox { get; set; }

        public int? Value { get; set; } 
    }

    public enum GroupingOrientation
    {
        Vertical,
        Horizontal,
    }
}

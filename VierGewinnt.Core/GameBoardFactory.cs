using System;
using System.Collections.Generic;
using System.Data;

namespace VierGewinnt.Core
{
    public class GameBoardFactory
    {
        public GameBoard Create(int rowCount, int columnCount)
        {
            if (columnCount < 2) throw new ArgumentOutOfRangeException(nameof(columnCount), "The number of columns must not be less than 2");
            if (rowCount < 2) throw new ArgumentOutOfRangeException(nameof(rowCount), "The number of rows must not be less than 2");
            
            var fields = new Field[columnCount][];
            for (var i = 0; i < columnCount; i++)
            {
                fields[i] = new Field[rowCount];
                for (var j = 0; j < rowCount; j++)
                {
                    fields[i][j] = new Field(i,j);
                }
            }

            var columns = new List<Column>();
            for (var i = 0; i < columnCount; i++)
            {
                var columnFields = new List<Field>();
                for (var j = 0; j < rowCount; j++)
                {
                    columnFields.Add(fields[i][j]);
                }
                columns.Add(new Column(columnFields));
            }

            var rows = new List<Row>();
            for (var j = 0; j < rowCount; j++)
            {
                var rowFields = new List<Field>();

                for (var i = 0; i < columnCount; i++)
                {
                    rowFields.Add(fields[i][j]);
                }

                rows.Add(new Row(rowFields));
            }

            var diagonals = new List<Diagonal>();
            var diagonalDirection = DiagonalDirection.RightBottom;
            // diagonals upper left to bottom right

            for (var i = 0; i < columnCount; i++)
            {
                var columnIndex = i;
                var rowIndex = 0;

                var diagonalFields = new List<Field>();
                while (columnIndex < columnCount && rowIndex < rowCount)
                {
                    diagonalFields.Add(fields[columnIndex][rowIndex]);
                    columnIndex++;
                    rowIndex++;
                }

                if (diagonalFields.Count >= 4)
                {
                    diagonals.Add(new Diagonal(i,0,diagonalDirection,diagonalFields));
                }
            }

            for (var j = 1; j < rowCount; j++)
            {
                var columnIndex = 0;
                var rowIndex = j;

                var diagonalFields = new List<Field>();

                while (columnIndex < columnCount && rowIndex < rowCount)
                {
                    diagonalFields.Add(fields[columnIndex][rowIndex]);
                    columnIndex++;
                    rowIndex++;
                }
                if(diagonalFields.Count >=4)
                {
                    diagonals.Add(new Diagonal(0,j,diagonalDirection,diagonalFields));
                }
            }

            // diagonals from upper right to bottom left
            diagonalDirection = DiagonalDirection.LeftBottom;

            for (var i = 0; i < columnCount; i++)
            {
                var columnIndex = i;
                var rowIndex = 0;
                var diagonalFields = new List<Field>();
                while (columnIndex >=0 && rowIndex < rowCount)
                {
                    diagonalFields.Add(fields[columnIndex][rowIndex]);
                    columnIndex--;
                    rowIndex++;
                }

                if (diagonalFields.Count >= 4)
                {
                    diagonals.Add(new Diagonal(i,0,diagonalDirection,diagonalFields));
                }
            }

            for (int j = 1; j < rowCount; j++)
            {
                var columnIndex = columnCount - 1;
                var rowIndex = j;
                var diagonalFields = new List<Field>();

                while (columnIndex >= 0 && rowIndex < rowCount)
                {
                    diagonalFields.Add(fields[columnIndex][rowIndex]);
                    columnIndex--;
                    rowIndex++;
                }

                if (diagonalFields.Count >= 4)
                {
                    diagonals.Add(new Diagonal(columnCount-1,j,diagonalDirection,diagonalFields));
                }
            }


            return new GameBoard(fields,rows,columns,diagonals);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;

namespace VierGewinnt.Core
{
    public class GameBoardFactory
    {
        public GameBoard Create(int rowCount, int columnCount)
        {
            if (columnCount < 2) throw new ArgumentOutOfRangeException("columnCount", "The number of columns must not be less than 2");
            if(rowCount < 2) throw new ArgumentOutOfRangeException("rowCount", "The number of rows must not be less than 2");
            
            var fields = new Field[columnCount][];
            for (var i = 0; i < columnCount; i++)
            {
                fields[i] = new Field[rowCount];
                for (var j = 0; j < rowCount; j++)
                {
                    fields[i][j] = new Field();
                }

            }

            var column = new List<Column>();
            for (var i = 0; i < columnCount; i++)
            {
                var columnFields = new List<Field>();
                for (var j = 0; j < rowCount; j++)
                {
                    columnFields.Add(fields[i][j]);
                }
                column.Add(new Column(columnFields));
            }

            var rows = new List<Row>();
            for (var j = 0; j < rowCount; j++)
            {
                var rowFields = new List<Field>();

                for (var i = 0; i < columnCount; i++)
                {
                    rowFields.Add(fields[j][i]);
                }

                rows.Add(new Row(rowFields));
            }

            var diagonals = new List<Diagonal>();
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
                    diagonals.Add(new Diagonal(diagonalFields));
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
                    diagonals.Add(new Diagonal(diagonalFields));
                }
            }

            // diagonals from upper right to bottom left

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
                    diagonals.Add(new Diagonal(diagonalFields));
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
                    diagonals.Add(new Diagonal(diagonalFields));
                }
            }

            return new GameBoard();
        }
    }
}
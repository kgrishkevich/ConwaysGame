using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace ConwaysGame
{
    class Universe
    {
        #region public data and methods

        public Universe(UInt64 size)
        {
            Size = size;
            _currentState = new Dictionary<string, Cell>();
            _neighborCounter = new Dictionary<string, Cell>();
        }

        public UInt64 Size { get; private set; }

        public void Clear()
        {
            _currentState.Clear();
            _neighborCounter.Clear();
        }

        public bool AddAliveCell(UInt64 x, UInt64 y)
        {
            if ((x < 0) || (x >= Size))
                throw new Exception("Adding cell with wrong X position!");

            if ((y < 0) || (y >= Size))
                throw new Exception("Adding cell with wrong Y position!");

            Cell cell = new Cell(x, y);
            if (!_currentState.ContainsKey(cell.Key))
            {
                _currentState.Add(cell.Key, cell);
                return true;
            }
            else
                return false;
        }

        public bool RemoveAliveCell(UInt64 x, UInt64 y)
        {
            Cell cell = new Cell(x, y);
            if (_currentState.ContainsKey(cell.Key))
            {
                _currentState.Remove(cell.Key);
                return true;
            }
            else
                return false;
        }

        public void GenerateNextState()
        {
            _neighborCounter.Clear();

            foreach (Cell cell in _currentState.Values)
            {
                foreach (Cell neighbor in GetNeighbors(cell))
                {
                    if (_neighborCounter.ContainsKey(neighbor.Key))
                    {
                        Cell cellNeighbor = _neighborCounter[neighbor.Key];
                        cellNeighbor.NeighborsCount++;
                    }
                    else
                    {
                        if (_currentState.ContainsKey(neighbor.Key))
                            neighbor.IsAlive = true;

                        neighbor.NeighborsCount++;
                        _neighborCounter.Add(neighbor.Key, neighbor);
                    }
                }
            }

            lock (_currentState)
            {
                _currentState.Clear();

                foreach (Cell cell in _neighborCounter.Values)
                {
                    if (cell.IsAlive)
                    {
                        if ((cell.NeighborsCount >= 2) && (cell.NeighborsCount <= 3))
                            _currentState.Add(cell.Key, cell);
                    }
                    else
                    {
                        if (cell.NeighborsCount == 3)
                        {
                            cell.IsAlive = true;
                            _currentState.Add(cell.Key, cell);
                        }
                    }
                }
            }
        }

        public void WriteCurrentState(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(Size);

            foreach (Cell cell in _currentState.Values)
            {
                writer.Write(cell.X);
                writer.Write(cell.Y);
            }

            writer.Close();
            stream.Close();
        }

        public void ReadCurrentState(string fileName)
        {
            _currentState.Clear();

            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);
            Size = reader.ReadUInt64();

            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                UInt64 x = reader.ReadUInt64();
                UInt64 y = reader.ReadUInt64();

                Cell cell = new Cell(x, y);
                _currentState.Add(cell.Key, cell);
            }

            reader.Close();
            stream.Close();
        }

        public void DrawCurrentState(Graphics graphics, SolidBrush cellBrush, int dx, int dy)
        {
            lock (_currentState)
            {
                foreach (Cell cell in _currentState.Values)
                {
                    int x = Convert.ToInt32(cell.X) * dx;
                    int y = Convert.ToInt32(cell.Y) * dy;

                    graphics.FillRectangle(cellBrush, x, y, dx, dy);
                }
            }
        }

        #endregion public data and methods


        #region private data and methods

        private Dictionary<string, Cell> _currentState;
        private Dictionary<string, Cell> _neighborCounter;

        private UInt64 GetPrevIndex(UInt64 index)
        {
            if (index > 0)
                index--;
            else
            {
                index = Size - 1;
            }

            return index;
        }

        private UInt64 GetNextIndex(UInt64 index)
        {
            if (index < Size - 1)
                index++;
            else
            {
                index = 0;
            }

            return index;
        }

        private List<Cell> GetNeighbors(Cell cell)
        {
            List<Cell> neighbors = new List<Cell>();

            Cell cellLeftUp = new Cell(GetPrevIndex(cell.X), GetPrevIndex(cell.Y));
            neighbors.Add(cellLeftUp);

            Cell cellUp = new Cell(cell.X, GetPrevIndex(cell.Y));
            neighbors.Add(cellUp);

            Cell cellRightUp = new Cell(GetNextIndex(cell.X), GetPrevIndex(cell.Y));
            neighbors.Add(cellRightUp);

            Cell cellLeft = new Cell(GetPrevIndex(cell.X), cell.Y);
            neighbors.Add(cellLeft);

            Cell cellRight = new Cell(GetNextIndex(cell.X), cell.Y);
            neighbors.Add(cellRight);

            Cell cellLeftDown = new Cell(GetPrevIndex(cell.X), GetNextIndex(cell.Y));
            neighbors.Add(cellLeftDown);

            Cell cellDown = new Cell(cell.X, GetNextIndex(cell.Y));
            neighbors.Add(cellDown);

            Cell cellRightDown = new Cell(GetNextIndex(cell.X), GetNextIndex(cell.Y));
            neighbors.Add(cellRightDown);

            return neighbors;
        }

        #endregion private data and methods
    }
}

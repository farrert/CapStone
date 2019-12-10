using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone.Models
{
    class Board : ObservableObject
    {
        #region Enum

        public enum Position { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16 }

        #endregion

        #region Fields

        private List<Box> _boardState;
        private ObservableCollection<Box> _boxes;

        #endregion

        #region Properties

        public List<Box> BoardState
        {
            get { return _boardState; }
            set => _boardState = value;
        }
        public ObservableCollection<Box> Boxes
        {
            get { return _boxes; }
            set { _boxes = value; }
        }
        #endregion

        #region Constructors
        public Board()
        {

        }
        #endregion
    }
}

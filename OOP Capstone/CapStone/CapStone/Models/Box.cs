using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapStone.ViewModels.GameViewModel;

namespace CapStone.Models
{
    public class Box : ObservableObject
    {
        #region Enum

        public enum BoxState { Empty, X, O }
        private Dictionary<string, BoxState> CurrentBox = new Dictionary<string, BoxState>()
        {
            { "", BoxState.Empty },
            { "X", BoxState.X },
            { "O", BoxState.O }
        };

        #endregion

        #region Fields

        private BoxState _state;
        private int _pos;

        #endregion

        #region Properties

        public int Pos
        {
            get { return _pos; }
            set {
                _pos = value;
                OnPropertyChanged("Pos");
            }
        }
        public BoxState State
        {
            get { return _state; }
            set
            {
                _state = value;
                OnPropertyChanged(nameof(BoxState));
            }
        }
        #endregion

        #region Constructors
        public Box()
        {

        }
        #endregion
    }
}
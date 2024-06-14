using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IColorObserver
    {
        void OnColorChanged(Color color);
    }

    public interface IObservable
    {
        void Subscribe(IColorObserver observer);
        void UnSubscribe(IColorObserver observer);
        void Notify();
    }

    public class ColorObservable : IObservable
    {
        private List<IColorObserver> observers = new List<IColorObserver>();
        private Color color;
        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                Notify();
            }

        }

        public void Notify()
        {
            observers.ForEach(o => o.OnColorChanged(color));
        }

        public void Subscribe(IColorObserver observer)
        {
            observers.Add(observer);
        }

        public void UnSubscribe(IColorObserver observer)
        {
            observers.Remove(observer);
        }
    }
}

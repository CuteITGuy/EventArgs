using System.Windows;


namespace CB.Wpf
{
    public class RoutedEventArgs<T>: RoutedEventArgs
    {
        #region  Constructors & Destructor
        public RoutedEventArgs() { }

        public RoutedEventArgs(T value): this(value, null, null) { }

        public RoutedEventArgs(T value, RoutedEvent routedEvent): this(value, routedEvent, null) { }

        public RoutedEventArgs(T value, RoutedEvent routedEvent, object source): base(routedEvent, source)
        {
            Value = value;
        }
        #endregion


        #region  Properties & Indexers
        public T Value { get; set; }
        #endregion
    }
}
namespace EventDrivenPattern;

public class EventBus
{
    private readonly Dictionary<Type, List<Action<object>>> _subscribers = new();

    public void Subscribe<T>(Action<T> handler)
    {
        if (!_subscribers.ContainsKey(typeof(T)))
        {
            _subscribers[typeof(T)] = new List<Action<object>>();
        }

        _subscribers[typeof(T)].Add(evt => handler((T)evt));
    }

    public void Publish<T>(T eventItem)
    {
        if (_subscribers.ContainsKey(eventItem!.GetType()))
        {
            foreach (var handler in _subscribers[eventItem.GetType()])
            {
                handler(eventItem);
            }
        }
    }
}
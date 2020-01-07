# events
- Events have publishers and subscribers. A given event may have many subscribers or no subscribers.
- Use a delegate type to define an event, as in the following code:
```
public delegate void OverdrawnEventHandler(); 
public event OverdrawnEventHandler Overdrawn;
```
- You can use the predefined Action delegate type to define events, as in the following code:
```
public event Action Overdrawn;
```
-  Microsoft best practice: Make the event’s first parameter a sender object and the second an object that gives more information about the event. Derive the type of the object from the EventArgs class, and end its name with Args as in OverdrawnEventArgs. ➤➤ You can use the predefined EventHandler delegate type to define an event that takes an object named sender as a first parameter and an event data object as a second parameter, as shown in the following code:
public event EventHandler<OverdrawnEventArgs> Overdrawn;
- Raise an event, as in the following code:
if (EventName != null) EventName(arguments...);
- Classes cannot inherit events. To make it possible for derived classes to raise base class events, give the base class an OnEventName method that raises the event. ➤➤ A program can use += and -= to subscribe and unsubscribe from events. ➤➤ If a program subscribes to an event more than once, the event handler is called multiple times.
-If a program unsubscribes from an event more times than it was subscribed, nothing bad happens.

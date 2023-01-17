using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// All events are handled with a string argument (JSON). Publisher and subsscribers should agree on the parameter class
/// which will be serialized and deserialized on the string. 
/// USAGE : In test scripts dir, there are PublisherTest and SubscriberTest scripts.Publisher registers an event KEYSPACEPRESSED
/// and subsciber listen to this event and upon happens, write the event name to the console.
/// TEST : create two empty game objects, Pub and Sub. Attach the test scripts to them, run the game and press SPACE
/// 
public class GenericEventHandler
{
    public event EventHandler<string> eHandler;
    public void TriggerEvent(string eArgs)
    {
        eHandler(this, eArgs);
    }
}

public class EventManager
{
    public Dictionary<string, GenericEventHandler> PubEvents = new Dictionary<string, GenericEventHandler>();

    /// For Publishers
    public bool RegisterPub(string eventName)
    {
        if (PubEvents.ContainsKey(eventName))
        {   /// Can only be one publisher with a certanin eventname OR
            //Debug.LogFormat("Attemp to Register an Already Registered event {0}", eventName);
            //return false;
            /// A subscriber has already created this entry, so just use it
            return true;
        }
        else
        {
            PubEvents.Add(eventName, new GenericEventHandler());
#if SHOWDEBUG
            Debug.LogFormat("RegisterPub: event {0} is registered", eventName);
#endif
            return true;
        }
    }
    /// For Subscribers
    public bool RegisterSub(string eventName, EventHandler<string> eventHandler)
    {
        if (!PubEvents.ContainsKey(eventName))
        {/// An event should be registered by a publisher before OR
            //Debug.LogFormat("Attemp to Subscribe an Unregistered event {0}", eventName);
            //return false;
            /// Register this event, publisher will use it later
            PubEvents.Add(eventName, new GenericEventHandler());
            PubEvents[eventName].eHandler += eventHandler;
#if SHOWDEBUG
            Debug.LogFormat("RegisterSub: event {0} is registered", eventName);
#endif
            return true;

        }
        else
        {
            PubEvents[eventName].eHandler += eventHandler;
            return true;
        }
    }

    public void TriggerEvent(string eventName, string eArgs)
    {
        if (PubEvents.ContainsKey(eventName))
        {
            PubEvents[eventName].TriggerEvent(eArgs);
        }
        else Debug.LogFormat("Attemp to Trigger an Unregistered event {0}", eventName);
    }

}

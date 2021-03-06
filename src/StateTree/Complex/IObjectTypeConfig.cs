﻿using Skclusive.Mobx.Observable;
using System;
using System.Collections.Generic;

namespace Skclusive.Mobx.StateTree
{
    public interface IObjectTypeConfig<S, T>
    {
        string Name { get; }

        IReadOnlyCollection<IMutableProperty> Mutables { get; }

        IReadOnlyDictionary<Hook, List<Action<object[]>>> Hooks { get; }

        IReadOnlyCollection<IVolatileProperty> Volatiles { get; }

        IReadOnlyCollection<IViewProperty> Views { get; }

        IReadOnlyCollection<IActionProperty> Actions { get; }

        IReadOnlyCollection<Func<object, object>> Initializers { get; }

        Func<object, object> PreProcessor { get; }

        Func<IObservableObject<T, INode>, T> Proxify { get; }

        Func<S> Snapshoty { get; }
    }
}

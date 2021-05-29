﻿//
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;

// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SniffCore
{
    /// <summary>
    ///     An EventArgs with one parameter.
    /// </summary>
    /// <typeparam name="T">The parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int>(first));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int> e)
    ///     {
    ///         // e.Item1
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T> : EventArgs
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        public EventArgs(T item1)
        {
            Item1 = item1;
        }

        /// <summary>
        ///     Gets the first parameter.
        /// </summary>
        public T Item1 { get; }
    }

    /// <summary>
    ///     An EventArgs with two parameters.
    /// </summary>
    /// <typeparam name="T1">The first parameter type.</typeparam>
    /// <typeparam name="T2">The second parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int, int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first, int second)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int, int>(first, second));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int, int> e)
    ///     {
    ///         // e.Item1
    ///         // e.Item2
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T1, T2> : EventArgs<T1>
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        /// <param name="item2">The second parameter.</param>
        public EventArgs(T1 item1, T2 item2)
            : base(item1)
        {
            Item2 = item2;
        }

        /// <summary>
        ///     Gets the second parameter.
        /// </summary>
        public T2 Item2 { get; }
    }

    /// <summary>
    ///     An EventArgs with three parameters.
    /// </summary>
    /// <typeparam name="T1">The first parameter type.</typeparam>
    /// <typeparam name="T2">The second parameter type.</typeparam>
    /// <typeparam name="T3">The third parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int, int, int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first, int second, int third)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int, int, int>(first, second, third));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int, int, int> e)
    ///     {
    ///         // e.Item1
    ///         // e.Item2
    ///         // e.Item3
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T1, T2, T3> : EventArgs<T1, T2>
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        /// <param name="item2">The second parameter.</param>
        /// <param name="item3">The third parameter.</param>
        public EventArgs(T1 item1, T2 item2, T3 item3)
            : base(item1, item2)
        {
            Item3 = item3;
        }

        /// <summary>
        ///     Gets the third parameter.
        /// </summary>
        public T3 Item3 { get; }
    }

    /// <summary>
    ///     An EventArgs with four parameters.
    /// </summary>
    /// <typeparam name="T1">The first parameter type.</typeparam>
    /// <typeparam name="T2">The second parameter type.</typeparam>
    /// <typeparam name="T3">The third parameter type.</typeparam>
    /// <typeparam name="T4">The fourth parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int, int, int, int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first, int second, int third, int fourth)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int, int, int, int>(first, second, third, fourth));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int, int, int, int> e)
    ///     {
    ///         // e.Item1
    ///         // e.Item2
    ///         // e.Item3
    ///         // e.Item4
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T1, T2, T3, T4> : EventArgs<T1, T2, T3>
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        /// <param name="item2">The second parameter.</param>
        /// <param name="item3">The third parameter.</param>
        /// <param name="item4">The fourth parameter.</param>
        public EventArgs(T1 item1, T2 item2, T3 item3, T4 item4)
            : base(item1, item2, item3)
        {
            Item4 = item4;
        }

        /// <summary>
        ///     Gets the fourth parameter.
        /// </summary>
        public T4 Item4 { get; }
    }

    /// <summary>
    ///     An EventArgs with five parameters.
    /// </summary>
    /// <typeparam name="T1">The first parameter type.</typeparam>
    /// <typeparam name="T2">The second parameter type.</typeparam>
    /// <typeparam name="T3">The third parameter type.</typeparam>
    /// <typeparam name="T4">The fourth parameter type.</typeparam>
    /// <typeparam name="T5">The fifth parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int, int, int, int, int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first, int second, int third, int fourth, int fifth)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int, int, int, int, int>(first, second, third, fourth, fifth));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int, int, int, int, int> e)
    ///     {
    ///         // e.Item1
    ///         // e.Item2
    ///         // e.Item3
    ///         // e.Item4
    ///         // e.Item5
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T1, T2, T3, T4, T5> : EventArgs<T1, T2, T3, T4>
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        /// <param name="item2">The second parameter.</param>
        /// <param name="item3">The third parameter.</param>
        /// <param name="item4">The fourth parameter.</param>
        /// <param name="item5">The fifth parameter.</param>
        public EventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
            : base(item1, item2, item3, item4)
        {
            Item5 = item5;
        }

        /// <summary>
        ///     Gets the fifth parameter.
        /// </summary>
        public T5 Item5 { get; }
    }

    /// <summary>
    ///     An EventArgs with six parameters.
    /// </summary>
    /// <typeparam name="T1">The first parameter type.</typeparam>
    /// <typeparam name="T2">The second parameter type.</typeparam>
    /// <typeparam name="T3">The third parameter type.</typeparam>
    /// <typeparam name="T4">The fourth parameter type.</typeparam>
    /// <typeparam name="T5">The fifth parameter type.</typeparam>
    /// <typeparam name="T6">The sixth parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int, int, int, int, int, int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first, int second, int third, int fourth, int fifth, int sixth)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int, int, int, int, int, int>(first, second, third, fourth, fifth, sixth));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int, int, int, int, int, int> e)
    ///     {
    ///         // e.Item1
    ///         // e.Item2
    ///         // e.Item3
    ///         // e.Item4
    ///         // e.Item5
    ///         // e.Item6
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T1, T2, T3, T4, T5, T6> : EventArgs<T1, T2, T3, T4, T5>
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        /// <param name="item2">The second parameter.</param>
        /// <param name="item3">The third parameter.</param>
        /// <param name="item4">The fourth parameter.</param>
        /// <param name="item5">The fifth parameter.</param>
        /// <param name="item6">The sixth parameter.</param>
        public EventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
            : base(item1, item2, item3, item4, item5)
        {
            Item6 = item6;
        }

        /// <summary>
        ///     Gets the sixth parameter.
        /// </summary>
        public T6 Item6 { get; }
    }

    /// <summary>
    ///     An EventArgs with seven parameters.
    /// </summary>
    /// <typeparam name="T1">The first parameter type.</typeparam>
    /// <typeparam name="T2">The second parameter type.</typeparam>
    /// <typeparam name="T3">The third parameter type.</typeparam>
    /// <typeparam name="T4">The fourth parameter type.</typeparam>
    /// <typeparam name="T5">The fifth parameter type.</typeparam>
    /// <typeparam name="T6">The sixth parameter type.</typeparam>
    /// <typeparam name="T7">The seventh parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int, int, int, int, int, int, int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first, int second, int third, int fourth, int fifth, int sixth, int seventh)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int, int, int, int, int, int, int>(first, second, third, fourth, fifth, sixth, seventh));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int, int, int, int, int, int, int> e)
    ///     {
    ///         // e.Item1
    ///         // e.Item2
    ///         // e.Item3
    ///         // e.Item4
    ///         // e.Item5
    ///         // e.Item6
    ///         // e.Item7
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T1, T2, T3, T4, T5, T6, T7> : EventArgs<T1, T2, T3, T4, T5, T6>
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        /// <param name="item2">The second parameter.</param>
        /// <param name="item3">The third parameter.</param>
        /// <param name="item4">The fourth parameter.</param>
        /// <param name="item5">The fifth parameter.</param>
        /// <param name="item6">The sixth parameter.</param>
        /// <param name="item7">The seventh parameter.</param>
        public EventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
            : base(item1, item2, item3, item4, item5, item6)
        {
            Item7 = item7;
        }

        /// <summary>
        ///     Gets the seventh parameter.
        /// </summary>
        public T7 Item7 { get; }
    }

    /// <summary>
    ///     An EventArgs with eight parameters.
    /// </summary>
    /// <typeparam name="T1">The first parameter type.</typeparam>
    /// <typeparam name="T2">The second parameter type.</typeparam>
    /// <typeparam name="T3">The third parameter type.</typeparam>
    /// <typeparam name="T4">The fourth parameter type.</typeparam>
    /// <typeparam name="T5">The fifth parameter type.</typeparam>
    /// <typeparam name="T6">The sixth parameter type.</typeparam>
    /// <typeparam name="T7">The seventh parameter type.</typeparam>
    /// <typeparam name="T8">The eight parameter type.</typeparam>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     public event EventHandler<EventArgs<int, int, int, int, int, int, int, int>> TheEvent;
    ///     
    ///     private void OnTheEvent(int first, int second, int third, int fourth, int fifth, int sixth, int seventh, int eight)
    ///     {
    ///         TheEvent?.Invoke(this, new EventArgs<int, int, int, int, int, int, int, int>(first, second, third, fourth, fifth, sixth, seventh, eight));
    ///     }
    /// }
    /// 
    /// public class OtherViewModel
    /// {
    ///     public OtherViewModel(ViewModel viewModel)
    ///     {
    ///         viewModel.TheEvent += OnTheEvent;
    ///     }
    /// 
    ///     private void OnTheEvent(object? sender, EventArgs<int, int, int, int, int, int, int, int> e)
    ///     {
    ///         // e.Item1
    ///         // e.Item2
    ///         // e.Item3
    ///         // e.Item4
    ///         // e.Item5
    ///         // e.Item6
    ///         // e.Item7
    ///         // e.Item8
    ///     }
    /// }
    /// ]]>
    ///     </code>
    /// </example>
    public class EventArgs<T1, T2, T3, T4, T5, T6, T7, T8> : EventArgs<T1, T2, T3, T4, T5, T6, T7>
    {
        /// <summary>
        ///     Creates a new instance of <see cref="EventArgs{T}" />.
        /// </summary>
        /// <param name="item1">The first parameter.</param>
        /// <param name="item2">The second parameter.</param>
        /// <param name="item3">The third parameter.</param>
        /// <param name="item4">The fourth parameter.</param>
        /// <param name="item5">The fifth parameter.</param>
        /// <param name="item6">The sixth parameter.</param>
        /// <param name="item7">The seventh parameter.</param>
        /// <param name="item8">The eight parameter.</param>
        public EventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
            : base(item1, item2, item3, item4, item5, item6, item7)
        {
            Item8 = item8;
        }

        /// <summary>
        ///     Gets the eight parameter.
        /// </summary>
        public T8 Item8 { get; }
    }
}
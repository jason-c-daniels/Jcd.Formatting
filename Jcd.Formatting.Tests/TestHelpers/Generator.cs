using System.Collections;
using System.Collections.Generic;

using Jcd.Validations;
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.Formatting.Tests.TestHelpers;

/// <inheritdoc />
/// <summary>
///    A base class to help with implementing state-transition based enumeration.
/// </summary>
/// <remarks>
///    1. This generator assumes a valid starting state, that will be returned (used to compute the initial return and new
///    state).
///    2. To successfully use this in an expected manner follow these steps: Capture current result. Transition to new
///    state. Set the continue flag to false if the new state is invalid or a terminal state, otherwise set it to true.
///    3. Always have a reachable terminating state, otherwise you'll have an infinite loop.
/// </remarks>
/// <typeparam name="TState">The type of the state data</typeparam>
/// <typeparam name="TResult">The type of the transition result data.</typeparam>
public class CaptureAndTransitionGenerator<TState, TResult> : IEnumerable<TResult>
   where TState : class
{
   #region Public Delegates

   /// <summary>
   ///    The state transition function signature.
   /// </summary>
   /// <param name="state">The data to manipulate</param>
   /// <param name="continue">A flag indicating if there are more states to transition to.</param>
   /// <returns>The result of the state transition operation</returns>
   public delegate TResult StateTransitionFunction(TState state, out bool @continue);

   #endregion Public Delegates

   #region Public Constructors

   /// <summary>
   ///    Constructs a state transition based IEnumerable data generator.
   /// </summary>
   /// <param name="initial">The initial state.</param>
   /// <param name="transitionFunction">The state transition function.</param>
   // ReSharper disable once MemberCanBeProtected.Global
   public CaptureAndTransitionGenerator(TState initial, StateTransitionFunction transitionFunction)
   {
      TransitionFunction = Argument.IsNotNull(transitionFunction);
      CurrentState       = initial;
   }

   #endregion Public Constructors

   #region Protected Fields

   /// <summary>
   ///    The current, internal state.
   /// </summary>
   protected readonly TState CurrentState;

   /// <summary>
   ///    The state transition function.
   /// </summary>
   // ReSharper disable once MemberCanBePrivate.Global
   protected readonly StateTransitionFunction TransitionFunction;

   #endregion Protected Fields

   #region Public Methods

   /// <summary>
   ///    Retrieves an enumerator that yields data from calling transitionFunction. This is
   ///    guaranteed to be called once for the initial state.
   /// </summary>
   /// <returns>The result of transitionFunction</returns>
   public IEnumerator<TResult> GetEnumerator()
   {
      bool @continue;

      do
      {
         yield return TransitionFunction(CurrentState, out @continue);
      } while (@continue);
   }

   /// <summary>
   ///    Retrieves an enumerator that yields data from calling transitionFunction(state, out
   ///    @continue). This is guaranteed to be called once for the initial state.
   /// </summary>
   /// <returns>The result of transitionFunction(state, out @continue)</returns>
   IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

   #endregion Public Methods
}
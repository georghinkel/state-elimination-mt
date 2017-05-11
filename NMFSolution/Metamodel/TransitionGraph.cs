//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.StateElimination.Transitiongraph
{
    
    
    /// <summary>
    /// The default implementation of the TransitionGraph class
    /// </summary>
    [XmlNamespaceAttribute("http://transitiongraph/1.0")]
    [XmlNamespacePrefixAttribute("transitiongraph")]
    [ModelRepresentationClassAttribute("http://transitiongraph/1.0#//TransitionGraph")]
    public partial class TransitionGraph : ModelElement, ITransitionGraph, IModelElement
    {
        
        private static Lazy<ITypedElement> _statesReference = new Lazy<ITypedElement>(RetrieveStatesReference);
        
        /// <summary>
        /// The backing field for the States property
        /// </summary>
        private ObservableCompositionOrderedSet<IState> _states;
        
        private static Lazy<ITypedElement> _transitionsReference = new Lazy<ITypedElement>(RetrieveTransitionsReference);
        
        /// <summary>
        /// The backing field for the Transitions property
        /// </summary>
        private ObservableCompositionOrderedSet<ITransition> _transitions;
        
        private static IClass _classInstance;
        
        public TransitionGraph()
        {
            this._states = new ObservableCompositionOrderedSet<IState>(this);
            this._states.CollectionChanging += this.StatesCollectionChanging;
            this._states.CollectionChanged += this.StatesCollectionChanged;
            this._transitions = new ObservableCompositionOrderedSet<ITransition>(this);
            this._transitions.CollectionChanging += this.TransitionsCollectionChanging;
            this._transitions.CollectionChanged += this.TransitionsCollectionChanged;
        }
        
        /// <summary>
        /// The states property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("states")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IOrderedSetExpression<IState> States
        {
            get
            {
                return this._states;
            }
        }
        
        /// <summary>
        /// The transitions property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("transitions")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IOrderedSetExpression<ITransition> Transitions
        {
            get
            {
                return this._transitions;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new TransitionGraphChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TransitionGraphReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://transitiongraph/1.0#//TransitionGraph")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveStatesReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.StateElimination.Transitiongraph.TransitionGraph.ClassInstance)).Resolve("states")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the States property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void StatesCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("States", e, _statesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the States property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void StatesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("States", e, _statesReference);
        }
        
        private static ITypedElement RetrieveTransitionsReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.StateElimination.Transitiongraph.TransitionGraph.ClassInstance)).Resolve("transitions")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Transitions property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransitionsCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Transitions", e, _transitionsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Transitions property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransitionsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Transitions", e, _transitionsReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int statesIndex = ModelHelper.IndexOfReference(this.States, element);
            if ((statesIndex != -1))
            {
                return ModelHelper.CreatePath("states", statesIndex);
            }
            int transitionsIndex = ModelHelper.IndexOfReference(this.Transitions, element);
            if ((transitionsIndex != -1))
            {
                return ModelHelper.CreatePath("transitions", transitionsIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "STATES"))
            {
                if ((index < this.States.Count))
                {
                    return this.States[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "TRANSITIONS"))
            {
                if ((index < this.Transitions.Count))
                {
                    return this.Transitions[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "STATES"))
            {
                return this._states;
            }
            if ((feature == "TRANSITIONS"))
            {
                return this._transitions;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._states))
            {
                return "states";
            }
            if ((container == this._transitions))
            {
                return "transitions";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://transitiongraph/1.0#//TransitionGraph")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TransitionGraph class
        /// </summary>
        public class TransitionGraphChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TransitionGraph _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransitionGraphChildrenCollection(TransitionGraph parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.States.Count);
                    count = (count + this._parent.Transitions.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.States.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Transitions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.States.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Transitions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IState statesCasted = item.As<IState>();
                if ((statesCasted != null))
                {
                    this._parent.States.Add(statesCasted);
                }
                ITransition transitionsCasted = item.As<ITransition>();
                if ((transitionsCasted != null))
                {
                    this._parent.Transitions.Add(transitionsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.States.Clear();
                this._parent.Transitions.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.States.Contains(item))
                {
                    return true;
                }
                if (this._parent.Transitions.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> statesEnumerator = this._parent.States.GetEnumerator();
                try
                {
                    for (
                    ; statesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = statesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    statesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> transitionsEnumerator = this._parent.Transitions.GetEnumerator();
                try
                {
                    for (
                    ; transitionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transitionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transitionsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IState stateItem = item.As<IState>();
                if (((stateItem != null) 
                            && this._parent.States.Remove(stateItem)))
                {
                    return true;
                }
                ITransition transitionItem = item.As<ITransition>();
                if (((transitionItem != null) 
                            && this._parent.Transitions.Remove(transitionItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.States).Concat(this._parent.Transitions).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TransitionGraph class
        /// </summary>
        public class TransitionGraphReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TransitionGraph _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransitionGraphReferencedElementsCollection(TransitionGraph parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.States.Count);
                    count = (count + this._parent.Transitions.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.States.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Transitions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.States.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Transitions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IState statesCasted = item.As<IState>();
                if ((statesCasted != null))
                {
                    this._parent.States.Add(statesCasted);
                }
                ITransition transitionsCasted = item.As<ITransition>();
                if ((transitionsCasted != null))
                {
                    this._parent.Transitions.Add(transitionsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.States.Clear();
                this._parent.Transitions.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.States.Contains(item))
                {
                    return true;
                }
                if (this._parent.Transitions.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> statesEnumerator = this._parent.States.GetEnumerator();
                try
                {
                    for (
                    ; statesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = statesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    statesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> transitionsEnumerator = this._parent.Transitions.GetEnumerator();
                try
                {
                    for (
                    ; transitionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transitionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transitionsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IState stateItem = item.As<IState>();
                if (((stateItem != null) 
                            && this._parent.States.Remove(stateItem)))
                {
                    return true;
                }
                ITransition transitionItem = item.As<ITransition>();
                if (((transitionItem != null) 
                            && this._parent.Transitions.Remove(transitionItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.States).Concat(this._parent.Transitions).GetEnumerator();
            }
        }
    }
}

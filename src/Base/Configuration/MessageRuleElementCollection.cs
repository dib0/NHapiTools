using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Element collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MessageRuleElementCollection<T> : ConfigurationElementCollection where T : BaseMessageRuleElement, new()
    {
        /// <summary>
        /// This
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return (T)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="ruleElement"></param>
        public void Add(T ruleElement)
        {
            BaseAdd(ruleElement);
        }

        /// <summary>
        /// Clear
        /// </summary>
        public void Clear()
        {
            BaseClear();
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="ruleElement"></param>
        public void Remove(T ruleElement)
        {
            BaseRemove(ruleElement.Name);
        }

        /// <summary>
        /// Remove at
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            BaseRemove(name);
        }

        #region Overridden methods
        /// <summary>
        /// Create new element
        /// </summary>
        /// <returns></returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new T();
        }

        /// <summary>
        /// Get element key
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((T)element).Name;
        }
        #endregion
    }
}
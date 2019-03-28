﻿using System.Collections.Generic;
using System.Reflection;

namespace DynamicMethodGeneration
{
    internal class DynamicMethodCache
    {
        private Dictionary<MethodInfo, DynamicMethod> _cache = new Dictionary<MethodInfo, DynamicMethod>();

        public void Add(MethodInfo methodInfo, DynamicMethod method)
        {
            if (!_cache.ContainsKey(methodInfo))
                _cache.Add(methodInfo, method);
        }

        public DynamicMethod Get(MethodInfo methodInfo)
        {
            if (!_cache.ContainsKey(methodInfo))
                return null;

            return _cache[methodInfo];
        }
    }
}

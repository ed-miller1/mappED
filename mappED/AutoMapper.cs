using System;
using System.Collections.Generic;
using System.Text;

namespace BevDevIO.mappED
{
    public static class AutoMapper
    {
        public static T MapTo<S, T>(S source)
        {
            var target = (T)Activator.CreateInstance(typeof(T));
            var sType = source.GetType();
            return default(T);
        }
    }
}

﻿namespace Store.Client
{
    public interface IProperty<Type>
    {
        public Type Value { get; set; }
    }
}

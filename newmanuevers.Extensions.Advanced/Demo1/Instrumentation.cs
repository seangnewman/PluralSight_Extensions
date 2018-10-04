﻿using System;

namespace newmanuevers.Extensions.Advanced.Demo1
{
    public sealed class Instrumentation
    {
        public Guid Id { get; set; }

        private DateTime _startedAt;

        public string ProcessName { get; set; }

        public Instrumentation()
        {
            Id = Guid.NewGuid();
        }

        public void Start()
        {
            _startedAt = DateTime.Now;
        }

        public int GetElapsedTime()
        {
            return (int)Math.Round(new TimeSpan(DateTime.Now.Ticks - _startedAt.Ticks).TotalSeconds, 0);
        }
    }
}

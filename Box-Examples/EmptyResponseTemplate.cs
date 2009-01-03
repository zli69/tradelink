﻿using System;
using System.Collections.Generic;
using System.Text;
using TradeLib;

namespace BoxExamples
{
    // you can copy+paste this to get a working response w/o all the comments
    public class EmptyResponseTemplate : Response
    {
        public void GotTick(Tick tick)
        {
        }
        public void GotOrder(Order order)
        {
        }
        public void GotFill(Trade fill)
        {
        }
        public void GotOrderCancel(uint cancelid)
        {
        }
        public void Reset() { }
        public void GotPosition(Position p) { }
        public bool isValid { get { return true; } }
        public string[] Indicators { get { return new string[0]; } set { } }
        public string Name { get { return ""; } set { } }
        public string FullName { get { return ""; } set { } }
        public event DebugFullDelegate SendDebug;
        public event OrderDelegate SendOrder;
        public event UIntDelegate SendCancel;
        public event ObjectArrayDelegate SendIndicators;
    }
}
﻿namespace SciAdvNet.SC3Script.Text
{
    /// <summary>
    /// Represents a serializer that takes an intermediate representation of an SC3 string and turns it into plain text.
    /// </summary>
    public abstract class SC3StringSerializer
    {
        public abstract string Serialize(SC3String sc3String);
        public abstract string SerializeSegment(SC3StringSegment segment);
    }
}
﻿using System;
namespace AppleMAUsIc.Model
{
	public class Track : IEquatable<Track>
	{
		public string Title { get; private set; }

		public TimeSpan Duration { get; private set; }

		public bool IsSingle { get; private set; }

        public int Position { get; internal set; } = 1;

        public Track(string title, TimeSpan duration, bool isSingle = false)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("The title of the track cannot be null or empty.");
            }
            if (duration.TotalSeconds < 10)
            {
                throw new ArgumentException("A track must be at least 10 seconds long to be considered as it is.");
            }
            Title = title;
            Duration = duration;
            IsSingle = isSingle;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (!GetType().Equals(obj.GetType())) return false;
            return Equals(obj as Track);
        }

        public bool Equals(Track other)
        {
            return other != null
                && other.Duration.Equals(Duration)
                && other.Title.Equals(Title);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Duration);
        }
        
        public override string ToString()
        {
            return $"[{Duration}] - {Title}";
        }
    }
}


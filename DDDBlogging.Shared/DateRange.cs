using System;

namespace DDDBlogging.Shared
{
    public class DateRange
    {
        public static readonly DateRange Empty = new DateRange();

        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        private DateRange()
        {
            Start = End = DateTime.MinValue;
        }

        public DateRange(DateTime start, DateTime end)
        {
            if (end < start)
            {
                throw new ArgumentException("La date de fin doit être supérieure à la date de début !", nameof(end));
            }

            Start = start;
            End = end;
        }

        // On pourrait ici ajouter toutes les méthodes nécessaires à la comparaison de deux fourchettes (intersection, supérieure, inférieure, ...)

        public override bool Equals(object obj)
        {
            var asDateRange = obj as DateRange;
            
            if (asDateRange == null)
            {
                return false;
            }

            return asDateRange.Start == Start && asDateRange.End == End;
        }

        public override int GetHashCode()
        {
            return new { Start, End }.GetHashCode();
        }
    }
}

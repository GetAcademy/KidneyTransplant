namespace KidneyTransplant
{
    internal class Person
    {
        private int _healthyKidneyCount;

        public Person()
        {
            _healthyKidneyCount = 2;
        }

        public bool GiveKidneyTo(Person receiver)
        {
            // donor = this
            // receiver = receiver
            if (_healthyKidneyCount != 2
                || receiver._healthyKidneyCount == 2) return false;

            receiver._healthyKidneyCount++;
            _healthyKidneyCount--;

            return true;
        }

        public void KidneyFailure()
        {
            if (_healthyKidneyCount == 0) return;
            _healthyKidneyCount--;
        }
    }
}

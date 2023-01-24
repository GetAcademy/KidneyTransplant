namespace KidneyTransplant
{
    internal class PersonX
    {
        private bool _leftKidney;
        private bool _rightKidney;

        public PersonX()
        {
            _leftKidney = true;
            _rightKidney = true;
        }

        private int GetKidneyCount()
        {
            return (_leftKidney?1:0) + (_rightKidney?1:0);
        }

        public bool GiveKidneyTo(PersonX receiver)
        {
            if (GetKidneyCount() != 2
                || receiver.GetKidneyCount() == 2) return false;

            //receiver._healthyKidneyCount++;
            //_healthyKidneyCount--;

            return true;
        }

        public void KidneyFailure()
        {
            //if (_healthyKidneyCount == 0) return;
            //_healthyKidneyCount--;
        }
    }
}
}

using System;


namespace R5T.S0053
{
    public class Construction : IConstruction
    {
        #region Infrastructure

        public static IConstruction Instance { get; } = new Construction();


        private Construction()
        {
        }

        #endregion
    }
}

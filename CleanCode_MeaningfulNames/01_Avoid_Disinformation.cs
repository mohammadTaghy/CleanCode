namespace CleanCode_MeaningfulNames
{

    public class Avoid_Disinformation
    {
        #region Beware of using names which vary in small ways
        public class XYZControllerForEfficientHandlingOfStrings
        {

        }
        public class XYZControllerForEfficientStorageOfStrings
        {

        }
        #endregion

        #region Use reserved words correctly
        class ReservedWordsSample
        {
            public string AcountList = "some information of account";
        }
        class UserFactory
        {

        }
        #endregion

        #region variant with the same pronunciation, the same shape
        class VaribaleMayReadWrong
        {
            int I = 0;
            int l = 0;
            public VaribaleMayReadWrong()
            {
                
                int a = l, O = 1;
                if (O == l)
                    a = O + 1;
                else
                    l = 0 + 1;
            }
            int x0 = 1;
            int xO = 1;
        }
        #endregion
    }
}
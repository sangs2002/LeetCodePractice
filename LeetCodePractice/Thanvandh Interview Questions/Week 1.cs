namespace LeetCodePractice.Thanvandh_Interview_Questions
{
    public class Week_1
    {

        #region Sample
        public class InsuranceClaim
        {
            public string VehicleType;
            public double ClaimAmount;

            public double CalculateClaimRate()
            {
                if (VehicleType == "Car")
                {
                    return ClaimAmount * 0.10;
                }
                else if (VehicleType == "Bike")
                {
                    return ClaimAmount * 0.05;
                }
                else if (VehicleType == "Truck")
                {
                    return ClaimAmount * 0.20;
                }
                else
                {
                    return ClaimAmount * 0.15;
                }
            }
        }


        public interface ICalculateClaimRate
        {
            double CalculateClaimRate(double ClaimAmount);
        }



        public class CarCalimamount : ICalculateClaimRate
        {

            public double CalculateClaimRate(double ClaimAmount)
            {
                return ClaimAmount * 0.10;
            }
        }

        public class BikeCalimamount : ICalculateClaimRate
        {

            public double CalculateClaimRate(double ClaimAmount)
            {
                return ClaimAmount * 0.10;
            }
        }

        public class TrusckCalimamount : ICalculateClaimRate
        {

            public double CalculateClaimRate(double ClaimAmount)
            {
                return ClaimAmount * 0.10;
            }
        }


        //Enacapsulation

        public class Claim
        {
            private double _ClaimAmount;


            public double Claimamount
            {
                get => _ClaimAmount;

                private set
                {
                    if (_ClaimAmount != value)
                    {
                        throw new InvalidOperationException("Not found");
                    }
                    _ClaimAmount = value;
                }

            }
        }
    }
    #endregion

    public class Insuranceclaim
    {
        public string VehicleType { get; set; }

        public double Amount { get; set; }


        public double CalculateClaimAmount() 
        {
           if(VehicleType == "car")
            {
                return Amount * 0.10;
            }
           else if (VehicleType == "bike")
            {
                return Amount * 0.05;
            }
            else if (VehicleType == "truck")
            {
                return Amount * 0.20;
            }

            else
            {
                return 0.100;
            }
        }

    }


    //Change inot proper OOPS and Solid principles
    public interface IInsurancePolicy
    {
        double CalculateClaimAmount(double amount);
    }

    public class CarPolicyrate : IInsurancePolicy
    {
        public double CalculateClaimAmount(double amount)
        {

            return amount * 0.10;
        }
    }

    public class BikePolicyrate : IInsurancePolicy
    {
        public double CalculateClaimAmount(double amount)
        {

            return amount * 0.05;
        }
    }

    public class TruckPolicyrate : IInsurancePolicy
    {
        public double CalculateClaimAmount(double amount)
        {

            return amount * 0.20;
        }
    }


    public class Claim
    {
        public double Amount { get; }

        public Claim(double amount)
        {
            if (Amount != amount)
            {
                throw new ArgumentException("not found");
            }

            Amount = amount;

        }
    }


    public class claimservice
    {

        private readonly IInsurancePolicy _policy;
        private readonly Claim _claim;
        public claimservice(IInsurancePolicy insurancePolicy, Claim claim)
        {
            _policy = insurancePolicy;
            _claim = claim;
        }

        public double CalculateClaim()
        {
            return _policy.CalculateClaimAmount(_claim.Amount);

        }
    }
}


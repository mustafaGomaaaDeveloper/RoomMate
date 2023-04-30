namespace RoomMateEgypt.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRoom Room{ get; set; }
        ICity City{ get; set; }
        IDistrict District{ get; set; }
        IFeature Feature{ get; set; }
        IUser User{ get; set; }
        IHousingType HousingType { get; set; }
        IPaymentRate PaymentRate { get; set; }
        ITerms Terms { get; set; }
        IPeriodOfAvailability PeriodOfAvailability { get; set; }
       


        int Complete();
    }
}

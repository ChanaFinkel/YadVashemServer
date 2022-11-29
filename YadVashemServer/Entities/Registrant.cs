

namespace Entities;

public class Registrant
{
    
    public string? country { get; set; }
    public string? institution { get; set; }
    public string? eventReservation { get; set; }
    public string? eventType { get; set; }
    public Contact contact { get; set; }
    public string? language { get; set; }
    public string? comments { get; set; }
    public string? divisionRouter { get; set; }
    public string? teachingSubject { get; set; }
    public string? reservationNum { get; set; }
    public int? ageGroup { get; set; }
    public string? groupName { get; set; }
     public string? schoolName { get; set; }
    public string? roleInSchool { get; set; }
    public bool isForGmul { get; set; }
    public bool isFromReservations { get; set; }
    public bool didGroupArrive { get; set; }
    public int numOfYoungParticipants { get; set; }
    public int numberOfParticipants { get; set; }
    public int groupNumber { get; set; }
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public DateTime? eventRegistrationActivityDay { get; set; }
    public int? numSeminarsAttendedOther { get; set; }
    public int? numSeminarsAttendedYv { get; set; }
    public string? citizenship { get; set; }
    public string? citySchool { get; set; }
    public string? nameOfInstitution { get; set; }
    public string? passportNumber { get; set; }
    public string? roomAccommodations { get; set; }
    public int totalPrice { get; set; }
    public int totalPriceAfterDiscount { get; set; }
    public string? currency { get; set; }
    public string? discountType { get; set; }
    public int discount { get; set; }
    public string? paymentReference { get; set; }
    public string? paymentComments { get; set; }
    public Decimal? paymentAmount { get; set; }
    public bool? paymentStatus { get; set; }
    public string? dietaryNeeds { get; set; }
    public string? dietaryNeedsOther { get; set; }
    public string? professionalCapacity { get; set; }
    public string? teachingSubjects { get; set; }
    public string? studentsAges { get; set; }
    public string? teachingMainSources { get; set; }
    public string? mainContextWhichYouTeach { get; set; }
    public string? primaryReasonsForRegistering { get; set; }
    public List<string> attachmentList { get; set; }
    public string? fullEventReservation { get; set; }
    public string? id { get; set; }
    public bool isDeleted { get; set; }
    public bool isDirty { get; set; }
    public bool isCanceled { get; set; }
    public bool isActive { get; set; }
    public string? createdOn { get; set; }

}

namespace Exam_Cinema.Model
{
    public class MovieReview
    {
        public int MowieReviewId { get; set; }
        public int MovieId { get; set; }
        public virtual Film Movie { get; set; }
        public int UserId { get; set; }
        public string ReviewText { get; set; }
    }
}

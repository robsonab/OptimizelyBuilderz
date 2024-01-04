namespace Builderz
{
    public class CarouselImageUrlAttribute : ImageUrlAttribute
    {
        public CarouselImageUrlAttribute()
        : base("~/contenticons/Carousel.png") { }
        public CarouselImageUrlAttribute(string path)
        : base(path) { }
    }
}

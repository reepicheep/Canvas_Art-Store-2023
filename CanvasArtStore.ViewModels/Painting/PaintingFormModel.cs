﻿using CanvasArtStore.ViewModels.Category;

using System.ComponentModel.DataAnnotations;

using static CanvasArtStore.Common.EntityValidationConstants.Category;

using static CanvasArtStore.Common.EntityValidationConstants.Painting;


namespace CanvasArtStore.ViewModels.Painting
{
    public class PaintingFormModel
    {
        public PaintingFormModel()
        {
            this.Categories = new HashSet<PaintingSelectCategoryFormModel>();
        }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;


        // Address === Author NB!
        [Required]
        [StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength)]
        [Display(Name = "Author")]
        public string Author { get; set; } = null!; 

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength)]
        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; } = null!;

        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<PaintingSelectCategoryFormModel> Categories { get; set; }
    }
}
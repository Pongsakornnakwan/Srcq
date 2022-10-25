using FluentValidation;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Validations
{
    public class PlansValidation : AbstractValidator<Plans>
    {
        public PlansValidation()
        {
            RuleFor(x => x.code).NotEmpty().WithMessage("รหัสห้ามว่าง");
            RuleFor(x => x.name1).NotEmpty().WithMessage("ชื่อห้ามว่าง");
        }
    }
}

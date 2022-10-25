using FluentValidation;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Validations
{
    public class DesignValidation : AbstractValidator<Design>
    {
        public DesignValidation()
        {
            RuleFor(x => x.code).NotEmpty().WithMessage("รหัสห้ามว่าง");
            RuleFor(x => x.name).NotEmpty().WithMessage("ชื่อห้ามว่าง");
        }
    }
}

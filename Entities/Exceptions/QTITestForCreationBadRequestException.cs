﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions;

public class QTITestForCreationBadRequestException() : BadRequestException("QTITestForCreation object is null")
{
}
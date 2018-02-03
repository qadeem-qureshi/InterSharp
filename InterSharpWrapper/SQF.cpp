#include "Stdafx.h"
#include "..\InterSharp\SQF.h"
#include "SQF.h"

namespace InterSharp {
	float SQF::time()
	{
		return Native::SQF::time();
	}
}
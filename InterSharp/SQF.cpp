#include "intercept.hpp"
#include "SQF.h"

namespace InterSharp
{
	namespace Native
	{
		float SQF::time()
		{
			return intercept::sqf::time();
		}
	}
}
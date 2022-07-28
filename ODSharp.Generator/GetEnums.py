import odrive
import enum
import json
import sys

things = [getattr(odrive.enums, x) for x in dir(odrive.enums)]
enumdata = {
	x.__name__: {
		'flag': issubclass(x, enum.Flag),
		'values': {y.name: y.value for y in x} 
	} 
	for x in things if isinstance(x, type) and issubclass(x, enum.Enum)
}


json.dump(enumdata, sys.stdout, indent=4)
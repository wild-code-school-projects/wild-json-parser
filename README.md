# wild-json-parser
Parse a JSON file containing weather data.


## Task: Parsing a JSON File of Weather Data


Deserialize the JSON object into an object capable of holding the data from the JSON file.

### Validation Criteria:
- The "wind" node is converted into a Wind object.
- The "weather" node is converted into a Weather object.
- A class WeatherInfo aggregates the Wind and Weather classes.
- The WeatherInfo class contains all other information that does not fit into the Wind or Weather classes.

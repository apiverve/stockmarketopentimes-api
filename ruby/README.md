# Stock Market Open Times API - Ruby Gem

Stock Market Open Times checks if a global stock exchange is currently trading and provides its opening and closing times. Pass an exchange code like NYSE or LSE to get current open status (open, closed, weekend or holiday), the holiday name, official exchange name, and session hours. On paid plans, add schedule=true for the exchange's local time, half-day early closes, and the next open and close with a countdown in minutes.

## Installation

Add this line to your application's Gemfile:

```ruby
gem 'apiverve_stockmarketopentimes'
```

And then execute:

```bash
$ bundle install
```

Or install it yourself as:

```bash
$ gem install apiverve_stockmarketopentimes
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```ruby
require 'apiverve_stockmarketopentimes'

# Initialize the client
client = APIVerve::Stockmarketopentimes::Client.new(api_key: "YOUR_API_KEY")

# Make a request
response = client.execute({
  exchange: "NYSE",
  schedule: true
})

# Print the response
puts response
```


### Error Handling

```ruby
begin
  response = client.execute({ exchange: "NYSE", schedule: true })
  puts response["data"]
rescue APIVerve::Stockmarketopentimes::ValidationError => e
  puts "Validation error: #{e.errors.join(', ')}"
rescue APIVerve::Stockmarketopentimes::APIError => e
  puts "API error: #{e.message}"
  puts "Status code: #{e.status_code}"
end
```

### Debug Mode

```ruby
# Enable debug logging
client = APIVerve::Stockmarketopentimes::Client.new(
  api_key: "YOUR_API_KEY",
  debug: true
)
```

## Example Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "timezone": "America/New_York",
    "exchange": "NYSE",
    "fullName": "New York Stock Exchange",
    "isOpen": false,
    "openingTime": "2026-11-06 09:30:00",
    "closingTime": "2026-11-06 16:00:00",
    "status": "closed",
    "holidayName": null,
    "localTime": "2026-11-06 01:26:52",
    "isHalfDay": false,
    "earlyCloseTime": null,
    "nextChange": "open",
    "nextOpen": "2026-11-06T09:30:00-05:00",
    "nextClose": "2026-11-06T16:00:00-05:00",
    "minutesUntilChange": 484,
    "calendarVerified": true
  }
}
```

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/stockmarketopentimes?utm_source=rubygems&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/stockmarketopentimes?utm_source=ruby&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/stockmarketopentimes?utm_source=ruby&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This gem is available under the [MIT License](LICENSE).

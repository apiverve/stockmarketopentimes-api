# Stock Market Open Times API - Ruby Gem

Stock Market Open Times checks if a global stock exchange is currently trading and provides its opening and closing times. Pass an exchange code like NYSE or LSE to get current open status, official exchange name, and session hours.

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
response = client.execute({ exchange: "NYSE" })

# Print the response
puts response
```


### Error Handling

```ruby
begin
  response = client.execute({ exchange: "NYSE" })
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
    "openingTime": "2025-12-16 09:30:00",
    "closingTime": "2025-12-16 16:00:00"
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

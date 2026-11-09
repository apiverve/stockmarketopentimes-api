# Stock Market Open Times API - PHP Package

Stock Market Open Times checks if a global stock exchange is currently trading and provides its opening and closing times. Pass an exchange code like NYSE or LSE to get current open status (open, closed, weekend or holiday), the holiday name, official exchange name, and session hours. On paid plans, add schedule=true for the exchange's local time, half-day early closes, and the next open and close with a countdown in minutes.

## Installation

Install via Composer:

```bash
composer require apiverve/stockmarketopentimes
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```php
<?php

require_once 'vendor/autoload.php';

use APIVerve\Stockmarketopentimes\Client;

// Initialize the client
$client = new Client('YOUR_API_KEY');

// Make a request
$response = $client->execute([
    'exchange' => 'NYSE',
    'schedule' => true
]);

// Print the response
print_r($response);
```


### Error Handling

```php
use APIVerve\Stockmarketopentimes\Client;
use APIVerve\Stockmarketopentimes\Exceptions\APIException;
use APIVerve\Stockmarketopentimes\Exceptions\ValidationException;

try {
    $response = $client->execute(['exchange' => 'NYSE', 'schedule' => true]);
    print_r($response['data']);
} catch (ValidationException $e) {
    echo "Validation error: " . implode(', ', $e->getErrors());
} catch (APIException $e) {
    echo "API error: " . $e->getMessage();
    echo "Status code: " . $e->getStatusCode();
}
```

### Debug Mode

```php
// Enable debug logging
$client = new Client(
    apiKey: 'YOUR_API_KEY',
    debug: true
);
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

## Requirements

- PHP 7.4 or higher
- Guzzle HTTP client

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/stockmarketopentimes?utm_source=packagist&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/stockmarketopentimes?utm_source=php&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/stockmarketopentimes?utm_source=php&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This package is available under the [MIT License](LICENSE).

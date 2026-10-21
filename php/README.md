# Stock Market Open Times API - PHP Package

Stock Market Open Times checks if a global stock exchange is currently trading and provides its opening and closing times. Pass an exchange code like NYSE or LSE to get current open status, official exchange name, and session hours.

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
$response = $client->execute(['exchange' => 'NYSE']);

// Print the response
print_r($response);
```


### Error Handling

```php
use APIVerve\Stockmarketopentimes\Client;
use APIVerve\Stockmarketopentimes\Exceptions\APIException;
use APIVerve\Stockmarketopentimes\Exceptions\ValidationException;

try {
    $response = $client->execute(['exchange' => 'NYSE']);
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
    "openingTime": "2025-12-16 09:30:00",
    "closingTime": "2025-12-16 16:00:00"
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

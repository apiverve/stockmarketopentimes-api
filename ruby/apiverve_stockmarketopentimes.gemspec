# frozen_string_literal: true

Gem::Specification.new do |spec|
  spec.name          = "apiverve_stockmarketopentimes"
  spec.version       = "1.2.3"
  spec.authors       = ["APIVerve"]
  spec.email         = ["hello@apiverve.com"]

  spec.summary       = "Stock Market Open Times API - Ruby Client"
  spec.description   = "Stock Market Open Times checks if a global stock exchange is currently trading and provides its opening and closing times. Pass an exchange code like NYSE or LSE to get current open status, official exchange name, and session hours."
  spec.homepage      = "https://apiverve.com/marketplace/stockmarketopentimes?utm_source=ruby&utm_medium=referral&utm_content=homepage"
  spec.license       = "MIT"
  spec.required_ruby_version = ">= 2.7.0"

  spec.metadata["homepage_uri"] = spec.homepage
  spec.metadata["source_code_uri"] = "https://github.com/apiverve/stockmarketopentimes-API/tree/main/ruby"
  spec.metadata["changelog_uri"] = "https://apiverve.com/changelog"
  spec.metadata["documentation_uri"] = "https://docs.apiverve.com/ref/stockmarketopentimes"

  spec.files = Dir.glob("{lib}/**/*") + %w[README.md LICENSE]
  spec.require_paths = ["lib"]

  spec.add_dependency "faraday", ">= 1.0", "< 3.0"
  spec.add_dependency "faraday-multipart", "~> 1.0"
  spec.add_dependency "json", "~> 2.0"
end

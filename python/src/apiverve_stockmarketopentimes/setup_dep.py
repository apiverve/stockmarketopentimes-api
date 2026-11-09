from setuptools import setup, find_packages

setup(
    name='apiverve_stockmarketopentimes',
    version='1.2.5',
    packages=find_packages(),
    include_package_data=True,
    install_requires=[
        'requests',
        'setuptools'
    ],
    description='Stock Market Open Times checks if a global stock exchange is currently trading and provides its opening and closing times. Pass an exchange code like NYSE or LSE to get current open status (open, closed, weekend or holiday), the holiday name, official exchange name, and session hours. On paid plans, add schedule=true for the exchange's local time, half-day early closes, and the next open and close with a countdown in minutes.',
    author='APIVerve',
    author_email='hello@apiverve.com',
    url='https://apiverve.com/marketplace/stockmarketopentimes?utm_source=pypi&utm_medium=referral&utm_content=homepage',
    classifiers=[
        'Programming Language :: Python :: 3',
        'Operating System :: OS Independent',
    ],
    python_requires='>=3.6',
)

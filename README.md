# Dustin price calculator

## The task

The code in this project calculates the price of a product.

Do a code refactor on this code to a level you yourself would want to maintain.

### Prerequisites

There are 2 types of products:
* Insurance
* Hardware

There are 2 types of users:
* Business (company)
* Consumer (normal)

### Requirements
The forumla to calculate the price is the following:

Product purchase price + product margin - discount

| Product type             | Margin   |
| ------------------------ | -------- |
| Insurance                | 25       |
| Hardware                 | 35       |

#### Discounts

If a campaign is active, subtract 10 kronor in discount.

As a business user you receive 5 kronor in discount.

### Feature wishlist
In the code you have the campaign discount is only active for insurances, we would like to see it work also for hardware!

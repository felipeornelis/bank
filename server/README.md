----
Entities
----

# User
    - Name
    - Username
    - Email
    - Password

# Bank
    - Name
    - Bacen Code
    - Icon

# Category
    - Name
    - Slug (?)
    - Icon
    - Category Type (income / epxense)

# Account
    - Name
    - Bank?
    - Expenses count
    - Incomes count
    - Transfer count

# Credit Card
    - Name
    - Statement closing date
    - Payment due date
    - Limit

# [Missing] Statement
    - Billing cycle
    - Statement sitatuion (open, late, paid)
    - Credit card Id

# [Missing] Transaction
    - Name
    - Description
    - Amount
    - Status
    - Operation Date
    - Category
    - Account
    - Attachment
    - Fixed Expense (boolean) // repeat every month
    - Repeat (int)
    - Operation Type (income or expense)
    
    - Statement (guided by the closing statement date)
    - Stallment (int)
    - Credit Card

# Planning
    - Amount
    - Percentage (% of the amount)

# EntityBase
    - Id (uuid)
    - CreatedAt
    - UpdatedAt
    - DeletedAt
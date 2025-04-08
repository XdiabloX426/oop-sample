# User Stories

This document contains user stories for the main features of the application.

## US001: Create a Purchase Order
**As a** procurement manager
**I want to** create a purchase order for a supplier
**So that** I can manage the procurement process efficiently.

### Acceptance Criteria
### Scenario 1
**Given** A supplier with code "SUP123", name "Microsoft, Inc.", and address "Redmond 110, NY, NY, USA",
**When** the procurement manager creates a purchase order with the supplier,
**Then** the purchase order should be created successfully with the supplier's details.
### Scenario 2
**Given** A supplier with code "SUP123", name "Microsoft, Inc.", and address "Redmond 110, NY, NY, USA",
**When** the procurement manager creates a purchase order with the supplier and adds items to it,
**Then** the system should throw an exception indication that the supplier does not exist.

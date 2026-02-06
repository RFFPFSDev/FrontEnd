# Project Idea: "Personal Finance Manager" Web App

## Core Features:

### Authentication Module

* Forms: Login, Signup, Password Reset
* State Management: Store user session, authentication status

### Dashboard Module

* Shows a summary of expenses, and budgets
* Use charts or graphs for visualization

### Expenses Module

* Forms: Add, edit, delete expenses
* Forms: Create/edit/delete budgets
* Validation: Ensure correct inputs (numbers, dates, categories)
* Set monthly budgets per category
* Create categories if new

### Notes:

* Lazy Loading all modules

# The same application implemented in 2 frameworks:

* React
* Angular

# Angular → React 

| Angular Concept | React Equivalent | Example |
|-----------------|----------------|---------|
| **Component** | Function / Class Component | `function Hello() { return <h1>Hello</h1>; }` |
| **Structural Directive** | Conditional rendering / List rendering | `*ngIf="show"` → `{show && <Component />}`<br>`*ngFor="let item of items"` → `{items.map(item => <Component key={item.id} {...item} />)}` |
| **Attribute Directive** | JSX props / inline style / className | `[ngClass]="condition"` → `className={condition ? "classA" : "classB"}`<br>`[ngStyle]="{color: isRed ? 'red':'blue'}"` → `style={{ color: isRed ? 'red' : 'blue' }}` |
| **Interpolation** | JSX curly braces | `{{name}}` → `{name}` |
| **Property Binding** | JSX props | `[src]="imageUrl"` → `<img src={imageUrl} />` |
| **Event Binding** | JSX events | `(click)="handleClick()"` → `<button onClick={handleClick}>Click</button>` |
| **Two-way Binding** | Controlled component (state + onChange) | `[(ngModel)]="value"` → `<input value={value} onChange={e => setValue(e.target.value)} />` |

# Hooks

## React

* useState -> Manages local component state. form inputs
* useEffect -> Handles side effects. Data fetching
* useMemo -> Prevents unnecessary recalculations

## Angular

* ngOnInit -> Runs once after Angular sets input properties. API calls
* ngOnChanges -. Runs when @Input() values change. Useful for reacting to parent → child updates
* ngOnDestroy -> Runs just before the component is destroyed. unsubscribe

# Route

## React

* BrowserRouter, Routes, useParams, useNavigate

## Angular

* RouterModule, Routes, router-outlet, routerLink

# Forms

## React

* Controlled components using useState
* Uncontrolled components using refs

## Angular

* Template-driven forms
* Reactive forms

# State Management

## React

* Redux

# Angular

* NgRx

# Modules

* Isolate parts of application in modules and lazy load modules
import tkinter as tk
from tkinter import messagebox
from sympy import symbols, Eq, lambdify
from scipy.optimize import bisect, brentq


def calculate_root():
    method = method_var.get()
    equation = equation_entry.get()
    guess_value = float(guess_entry.get())
    
    x = symbols('x')
    sympy_equation = Eq(eval(equation), 0)
    function = lambdify(x, sympy_equation.lhs - sympy_equation.rhs)
    
    if method == 'Bisection':
        try:
            root = bisect(function, guess_value - 1, guess_value + 1)
            messagebox.showinfo("Root", f"Bisection Method:\nRoot: {root}")
        except ValueError:
            messagebox.showerror("Error", "Bisection Method failed to converge.")
    elif method == 'Regular Falsi':
        try:
            root = brentq(function, guess_value - 1, guess_value + 1)
            messagebox.showinfo("Root", f"Regular Falsi Method:\nRoot: {root}")
        except ValueError:
            messagebox.showerror("Error", "Regular Falsi Method failed to converge.")


# Create the main window
window = tk.Tk()
window.title("Root Finder")
window.geometry("400x200")

# Create the input fields and labels
method_var = tk.StringVar()
method_label = tk.Label(window, text="Choose Method:")
method_label.pack()

method_frame = tk.Frame(window)
method_frame.pack()

bisection_rb = tk.Radiobutton(method_frame, text="Bisection", variable=method_var, value="Bisection")
bisection_rb.pack(side=tk.LEFT)

regular_falsi_rb = tk.Radiobutton(method_frame, text="Regular Falsi", variable=method_var, value="Regular Falsi")
regular_falsi_rb.pack(side=tk.LEFT)

equation_label = tk.Label(window, text="Enter Equation:")
equation_label.pack()

equation_entry = tk.Entry(window)
equation_entry.pack()

guess_label = tk.Label(window, text="Enter Guess Value:")
guess_label.pack()

guess_entry = tk.Entry(window)
guess_entry.pack()

# Create the calculate button
calculate_button = tk.Button(window, text="Calculate", command=calculate_root)
calculate_button.pack()

# Start the main loop
window.mainloop()

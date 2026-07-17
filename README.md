🚀 Data Structures & Algorithms (DSA) Basics | Study & Reference Guide

Welcome to the **[Data-structure-basics](https://github.com/AbdullahSaied52/Data-structure-basics)** repository! This project serves as a comprehensive, hands-on reference for key data structures, collections, and **LINQ (Language Integrated Query)** operations. 

It contains object-oriented programming (OOP) implementations written in both **C#** (~54.5%) and **C++** (~45.5%).

---

## 📌 Repository Structure

The project is organized logically to make browsing and studying the code straightforward:

*   📂 **`basics/`**: Contains core conceptual implementations of basic and advanced data structures.
*   📄 **`Program.cs`**: The main driver file containing practical, executable examples of C# collections, query operations, and custom object manipulations.
*   📄 **`Course22.sln`**: The Visual Studio solution file to easily load, build, and run the project.

---

## 📚 Deep-Dive: Covered Data Structures & Collections

This repository covers both custom-built and standard library collections, demonstrating their operations and practical use cases:

### 1. 🔗 Linked List
A dynamic data structure consisting of nodes where each node contains data and a pointer/reference to the next node.
*   **Time Complexity:** 
    *   Access / Search: $O(n)$
    *   Insertion / Deletion: $O(1)$ *(if the pointer to the location is already known)*

### 2. 🥞 Stack (LIFO)
A linear data structure that follows the **Last In, First Out** principle. Ideal for managing function calls, undo mechanisms, and backtracking.
*   **Time Complexity:** 
    *   Push / Pop / Peek: $O(1)$

### 3. 👥 Queue (FIFO)
A linear data structure that follows the **First In, First Out** principle. Widely used in task scheduling, buffering, and breadth-first searches.
*   **Time Complexity:** 
    *   Enqueue / Dequeue: $O(1)$

### 4. 🗂️ C# System Collections (Generic & Non-Generic)
The repository showcases the use of built-in C# data structures through practical scenarios:
*   **`List<T>`**: Dynamic arrays with operations like `Add`, `Insert`, `RemoveAll`, and conditional lookups.
*   **`Dictionary<TKey, TValue>`**: High-performance key-value maps utilizing `TryGetValue` and value grouping.
*   **`HashSet<T>`**: Unordered unique collections showcasing mathematical set operations: `UnionWith`, `IntersectWith`, `SymmetricExceptWith`, and subset validation.
*   **`SortedList<TKey, TValue>` & `SortedDictionary<TKey, TValue>`**: Demonstrating automatically sorted key-value structures.
*   **`ArrayList` (Legacy)**: Demonstrating how to use `.Cast<T>()` to query non-generic collections with modern LINQ.

---

## ⚡ LINQ (Language Integrated Query) Features Shown

Modern C# relies heavily on LINQ to manipulate datasets efficiently. This codebase includes examples of:
*   **Filtering**: `.Where(predicate)` (e.g., extracting matching objects or filtering criteria).
*   **Projection**: `.Select(selector)` (e.g., transforming object properties).
*   **Ordering**: `.OrderBy()` and `.OrderByDescending()`.
*   **Grouping**: `.GroupBy()` (e.g., grouping custom data structures).
*   **Aggregations**: `.Sum()`, `.Min()`, `.Max()`, `.Average()`, and `.Count()`.

---

## 🛠️ How to Get Started

### Prerequisites
*   Ensure you have the **.NET SDK** installed.
*   A C++ compiler (like GCC/MinGW) or **Visual Studio** / **VS Code**.

### Steps
1. Clone this repository to your local machine:
   ```bash
   git clone [https://github.com/AbdullahSaied52/Data-structure-basics.git](https://github.com/AbdullahSaied52/Data-structure-basics.git)

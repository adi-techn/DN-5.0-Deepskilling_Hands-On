using System;

namespace SearchFunctionExample
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }
    }

    class Program
    {
        static int LinearSearch(Product[] products, int targetId)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductId == targetId)
                    return i;
            }
            return -1;
        }

        static int BinarySearch(Product[] products, int targetId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (products[mid].ProductId == targetId)
                    return mid;

                if (products[mid].ProductId < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Phone", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Book", "Education")
            };

            int targetId = 104;

            int linearResult = LinearSearch(products, targetId);

            if (linearResult != -1)
                Console.WriteLine("Linear Search: Product found at index " + linearResult);
            else
                Console.WriteLine("Linear Search: Product not found");

            int binaryResult = BinarySearch(products, targetId);

            if (binaryResult != -1)
                Console.WriteLine("Binary Search: Product found at index " + binaryResult);
            else
                Console.WriteLine("Binary Search: Product not found");

        }
    }
}
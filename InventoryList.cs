using System;
using System.Collections.Generic;

namespace demos{
    class InventoryList<T> where T : Product{
        protected List<T> inventory;
        private int count;
        public InventoryList(){
            this.inventory = new List<T>();
            this.count = 0;
        }
        public void Add(T item){ 
            inventory.Add(item);
            count++;
        }
        public int getCount(){
            return this.count;
        }
        public Product findByName(string name){

            foreach(var item in this.inventory){
                if(item._name == name){
                    return item;
                }
            }
            return new Product();
        }
        public List<Product> findByType(string type){
            var temp = new List<Product>();
            
            foreach(var item in this.inventory){
                if(item._type == type){
                    temp.Add(item);
                }
            }
            return temp;
        }
        public void remove(string name){
            foreach(var item in this.inventory){
                if(item._name == name){
                    this.inventory.Remove(item);
                }
            }
        }

        public void addQuantity(string name,int quantity){
            foreach(var item in this.inventory){
                if(item._name == name){
                    item._quantity += quantity;
                }
                Console.WriteLine($"{item._name}'s quantity : {item._quantity}");
            }
        }
        public int calculateBill(Dictionary<string,int> items){
            int bill = 0;
            foreach(var item in items) {
                var x = this.findByName(item.Key);
                bill += (x._price*item.Value);
            }
            return bill;
        }
    }
}
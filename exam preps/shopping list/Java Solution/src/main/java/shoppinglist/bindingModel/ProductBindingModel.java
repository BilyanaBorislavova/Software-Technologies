package shoppinglist.bindingModel;

public class ProductBindingModel {

    private Integer id;


    private Integer Priority;


    private String Name;


    private Integer Quantity;

    private String Status;

    public ProductBindingModel(){

    }

    public ProductBindingModel(Integer id, Integer priority, String name, Integer quantity, String status) {
        this.id = id;
        Priority = priority;
        Name = name;
        Quantity = quantity;
        Status = status;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public Integer getPriority() {
        return Priority;
    }

    public void setPriority(Integer priority) {
        Priority = priority;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public Integer getQuantity() {
        return Quantity;
    }

    public void setQuantity(Integer quantity) {
        Quantity = quantity;
    }

    public String getStatus() {
        return Status;
    }

    public void setStatus(String status) {
        Status = status;
    }
}

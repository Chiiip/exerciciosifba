class CreateContacts < ActiveRecord::Migration
  def change
    create_table :contacts do |t|
      t.string :name
      t.date :birth
      t.string :email
      t.string :fone
      t.string :address
      t.text :obs

      t.timestamps
    end
  end
end

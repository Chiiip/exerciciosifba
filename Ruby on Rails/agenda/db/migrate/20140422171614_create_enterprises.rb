class CreateEnterprises < ActiveRecord::Migration
  def change
    create_table :enterprises do |t|
      t.string :fantasyname
      t.string :address
      t.string :fone
      t.text :obs

      t.timestamps
    end
  end
end
